import { Component, OnInit } from '@angular/core';
import { JournalService } from '../journal.service';
import { JournalEntry } from '../types';

@Component({
  selector: 'app-journal-add',
  templateUrl: './journal-add.component.html',
  styleUrls: ['./journal-add.component.scss']
})
export class JournalAddComponent implements OnInit {

  model = new JournalEntry();

  constructor(private journalService: JournalService) { }

  ngOnInit(): void {
  }

  public addJournalEntry(): void {
    this.journalService.addJournalEntry(this.model);
  }

  // TODO: Remove this when we're done
  diagnostic(): string { return JSON.stringify(this.model); }
}
