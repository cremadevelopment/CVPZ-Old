import { Component, OnInit } from '@angular/core';

import { JournalService } from '../journal.service';

@Component({
  selector: 'app-journal-list',
  templateUrl: './journal-list.component.html',
  styleUrls: ['./journal-list.component.scss']
})
export class JournalListComponent implements OnInit {

  constructor(protected journalService: JournalService) { }

  ngOnInit(): void { }

}
