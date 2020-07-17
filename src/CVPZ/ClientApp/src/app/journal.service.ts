import { Injectable } from '@angular/core';
import { JournalEntry } from './types';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError as observableThrowError, Subject, BehaviorSubject } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class JournalService {

  private apiUrl = 'api/JournalEntry';

  private _journalEntries: BehaviorSubject<JournalEntry[]> = new BehaviorSubject([]);
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

  private handleError(res: HttpErrorResponse): Observable<never> {
    console.error(res.error);
    return observableThrowError(res.error || 'Server Error');
  }
}
