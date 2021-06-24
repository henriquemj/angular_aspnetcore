import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any = [
    {
      EventoId: 1,
      Tema: 'Angular',
      Local: 'Belo Horizonte'
    },
    {
      EventoId: 2,
      Tema: '.Net Core',
      Local: 'Porto Alegre'
    },
    {
      EventoId: 3,
      Tema: 'Angular e .Net',
      Local: 'Vitória'
    }
  ];


  constructor() { }

  ngOnInit(): void {
  }

}
