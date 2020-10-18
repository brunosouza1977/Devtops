import { Component, Input, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap'

@Component({
  selector: 'app-modal-sucesso',
  templateUrl: './modal-sucesso.component.html',
  styleUrls: ['./modal-sucesso.component.scss']
})
export class ModalSucessoComponent implements OnInit {

  @Input() title: string;
  @Input() msg: string;
  @Input() okTxt: 'OK!';

  constructor(public bsModalRef: NgbModal) { }

  ngOnInit(): void {
  }

  onClose () {
    this.bsModalRef.dismissAll();
  }

}
