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

  constructor(journalService: JournalService) { }

  ngOnInit(): void {
  }

}
