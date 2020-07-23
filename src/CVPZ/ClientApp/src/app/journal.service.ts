import { Injectable } from '@angular/core';
import { JournalEntry } from './types';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError as observableThrowError, Subject, BehaviorSubject } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ObserveOnSubscriber } from 'rxjs/internal/operators/observeOn';

@Injectable({
  providedIn: 'root'
})
export class JournalService {

  private apiUrl = 'api/JournalEntry';

  private _journalEntries : BehaviorSubject<JournalEntry[]> = new BehaviorSubject([]);
  public readonly journalEntries: Observable<JournalEntry[]> = this._journalEntries.asObservable();

  constructor(private http: HttpClient) {
    this.loadInitialData();
  }

  private loadInitialData(): void {
    this.getJournalEntries().subscribe(res => this._journalEntries.next(res));
  }

  private getJournalEntries(): Observable<JournalEntry[]> {
    return this.http
      .get<JournalEntry[]>(`${this.apiUrl}`)
      .pipe(catchError(this.handleError));
  }

  public addJournalEntry(entry: JournalEntry): Observable<JournalEntry> {

    const journalPost: Observable<JournalEntry> = this.http.post<JournalEntry>(`${this.apiUrl}`, entry);

    journalPost.subscribe(
      res => {
        const entries = this._journalEntries.getValue();
        entries.push(res);
        this._journalEntries.next(entries);
      }
    );

    return journalPost;
  }

  private handleError(res: HttpErrorResponse): Observable<never> {
    console.error(res.error);
    return observableThrowError(res.error || 'Server Error');
  }
}
