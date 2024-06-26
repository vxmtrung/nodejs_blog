import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    {
                        path: 'dashboard',
                        loadChildren: () => import('./dashboard/dashboard.module').then((m) => m.DashboardModule),
                        data: { permission: 'Pages.Tenant.Dashboard' },
                    },
                    {
                        path: 'exam',
                        loadChildren: () => import('./exam/exam.module').then(m => m.ExamModule),
                        data: {permission: 'Pages.Tenant.Exam'}
                    },
                    {
                        path: 'student',
                        loadChildren: () => import('./student/student.module').then(m => m.StudentModule),
                        data : { permission: 'Pages.Tenant.Student' } 
                },
                    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
                    { path: '**', redirectTo: 'dashboard' },
                ],
            },
        ]),
    ],
    exports: [RouterModule],
})
export class MainRoutingModule {}
