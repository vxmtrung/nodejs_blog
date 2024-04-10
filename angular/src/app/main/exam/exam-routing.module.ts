import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import { ExamComponent } from './exam.component';
import { ViewExamComponent } from './view-exam/view-exam.component';
import { ViewExamResolverResolver } from './view-exam/view-exam-resolver.resolver';

const routes: Routes = [
    {
        path: '',
        component: ExamComponent,
        pathMatch: 'full'
    },
    {
        path: 'view-exam',
        component: ViewExamComponent,
        pathMatch: 'full'
    },
    {
        path: 'view-exam/:id',
        component: ViewExamComponent,
        pathMatch: 'full',
        resolve: {
            exam: ViewExamResolverResolver
        }
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ExamRoutingModule {}