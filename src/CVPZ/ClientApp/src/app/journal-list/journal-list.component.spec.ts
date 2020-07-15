import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JournalListComponent } from './journal-list.component';

describe('JournalListComponent', () => {
  let component: JournalListComponent;
  let fixture: ComponentFixture<JournalListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JournalListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JournalListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
