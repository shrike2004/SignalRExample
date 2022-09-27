import { Component } from '@angular/core';

import ruMessages from 'devextreme/localization/messages/ru.json';
import { loadMessages, locale } from 'devextreme/localization';
import config from 'devextreme/core/config';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'Client';
  constructor() {
    loadMessages(ruMessages);
    locale('ru-Ru');

    config({
      defaultCurrency: 'RUB',
    });
  }
}
