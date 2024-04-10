import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { StudentServiceProxy, StudentListDto, ListResultDtoOfStudentListDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './student.component.html',
    animations: [appModuleAnimation()]
})

export class StudentComponent extends AppComponentBase implements OnInit  {
    students: StudentListDto[] = [];
    filter: string = '';

    constructor(
        injector: Injector,
        private _studentService: StudentServiceProxy
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.getStudent();
    }

    getStudent(): void {
        this._studentService.getPeople(this.filter).subscribe((result) => {
            this.students = result.items;
        });
    }
}
