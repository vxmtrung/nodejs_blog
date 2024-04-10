import {NgModule} from '@angular/core';
import {AppSharedModule} from '@app/shared/app-shared.module';
import {StudentRoutingModule} from './student-routing.module';
import {StudentComponent} from './student.component';
import { SubheaderModule } from "../../shared/common/sub-header/subheader.module";

@NgModule({
    declarations: [StudentComponent],
    imports: [AppSharedModule, StudentRoutingModule, SubheaderModule]
})
export class StudentModule {}
