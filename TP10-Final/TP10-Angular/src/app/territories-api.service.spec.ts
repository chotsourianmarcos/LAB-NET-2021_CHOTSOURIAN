import { TestBed } from '@angular/core/testing';

import { TerritoriesAPIService } from './territories-api.service';

describe('TerritoriesAPIService', () => {
  let service: TerritoriesAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TerritoriesAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
