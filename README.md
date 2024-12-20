# Final Year Project Management System

A desktop application to streamline and enhance the management of final year projects in the Computer Science Department. This system ensures data integrity, consistency, and efficient handling of students, groups, advisors, projects, and evaluations.

## Features

- **User-Friendly Interface:**
  - Easy-to-navigate GUI with basic instructions on the home page.
- **Database Management System:**
  - Integrated with SQL Server for data consistency, integrity, and zero redundancy.
- **Student Management:**
  - Add and track student details with auto-generated IDs.
  - Prevents duplicate registration numbers for data accuracy.
- **Group Management:**
  - Create and manage student groups with auto-generated group IDs.
  - Supports marking group members as active/inactive.
- **Project Management:**
  - Assign projects to groups and manage project details with auto-generated IDs.
- **Advisory Board Management:**
  - Assign advisors (main, co-advisor, or industry) to projects.
  - Supports one advisor supervising multiple projects.
- **Evaluation Management:**
  - Auto-generate evaluation IDs and record marks for each group evaluation.
- **Report Generation:**
  - Generate PDF reports for:
    - Projects assigned to advisors.
    - Advisors assigned to students.
    - Students without groups.
    - Marksheets for evaluations.

## Tech Stack

- **Programming Language:** C#
- **Database:** MS SQL Server
- **Framework:** WinForms
- **PDF Generation:** iTextSharp
