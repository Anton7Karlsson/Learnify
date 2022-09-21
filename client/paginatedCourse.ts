import { Course } from "./src/models/course";

export interface PaginatedCourse {
    pageIndex: number;
    count: number;
    pageSize: number;
    data: Course[]
}