import { Component, OnInit } from '@angular/core';
import { CatalogService } from 'src/app/core/services/catalog.service';
import { DataService } from 'src/app/core/services/data.service';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  constructor(private catalogServie: CatalogService) { }

  ngOnInit(): void {
  }


  create (){
    this.catalogServie.create
  }


}
