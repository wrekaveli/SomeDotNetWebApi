import { Component, OnInit } from '@angular/core';
import { SomeClient, SomeModel } from './webapi';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'some-angular-client';

  something: SomeModel[] = [];

  constructor(readonly someClient: SomeClient) { }

  ngOnInit(): void {
    this.someClient.get()
      .subscribe(result => {
        this.something = result;
      });
  }
}
