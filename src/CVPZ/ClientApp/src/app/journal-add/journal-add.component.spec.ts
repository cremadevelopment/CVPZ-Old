import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JournalAddComponent } from './journal-add.component';

describe('JournalAddComponent', () => {
  let component: JournalAddComponent;
  let fixture: ComponentFixture<JournalAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JournalAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JournalAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
