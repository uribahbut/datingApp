import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-Value',
  templateUrl: './Value.component.html',
  styleUrls: ['./Value.component.css']
})
export class ValueComponent implements OnInit {

  constructor(private client: HttpClient) { }

  myvalues: any;

  ngOnInit() {
    this.getValues();
  }

  getValues() {
    this.client.get("http://localhost:5000/api/values")
      .subscribe(result => {
        this.myvalues = result
      }, err => { console.log(err) });
  }

}
