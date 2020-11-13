
import { TerceroConsultaComponent } from './tercero-consulta.component';
import { TestBed, ComponentFixture } from '@angular/core/testing';

describe('PersonaConsultaComponent', () => {
  let component: TerceroConsultaComponent;
  let fixture: ComponentFixture<TerceroConsultaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TerceroConsultaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TerceroConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
