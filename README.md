# ✈️ Airplane Takeoff Calculator (VB.NET Windows Forms Project)

## Overview

The Airplane Takeoff Calculator is a VB.NET Windows Forms application that calculates the time and distance required for an aircraft to take off based on its acceleration and required takeoff velocity.

The application demonstrates object-oriented programming, mathematical modeling, engineering calculations, and event-driven GUI development. Users can select an aircraft from a list and instantly view its calculated takeoff performance.

---

## Features

### Aircraft Selection
- Select an aircraft from a predefined list
- Display aircraft specifications
- Interactive ListBox interface

### Flight Performance Calculations
- Calculate required takeoff time
- Calculate takeoff distance
- Display acceleration data
- Display takeoff velocity requirements

### Dynamic Results
- Automatic calculation when an aircraft is selected
- Human-readable performance report
- Real-time updates

---

## Technologies Used

- VB.NET
- Windows Forms
- Object-Oriented Programming (OOP)
- Mathematical Modeling
- Event-Driven Programming

---

## Project Structure

```text
Airplane Takeoff Calculator
│
├── Form1.vb
│   ├── Aircraft Selection Logic
│   ├── Event Handling
│   ├── Result Display
│   └── User Interface Logic
│
├── Aircraft.vb
│   ├── Aircraft Properties
│   ├── Takeoff Time Calculation
│   ├── Takeoff Distance Calculation
│   └── Aircraft Data Model
│
├── Form1.Designer.vb
│   └── Windows Forms Layout
│
└── App.config
    └── Application Configuration
```

---

## Aircraft Data

The application contains the following aircraft:

| Aircraft | Takeoff Velocity (ft/s) | Acceleration (ft/s²) |
|-----------|------------------------|----------------------|
| A-747 | 250 | 33.5 |
| A-735 | 264 | 44.2 |
| C-150 | 270 | 37.1 |
| D-240 | 240 | 51.9 |

---

## Mathematical Model

### Takeoff Time

The time required for takeoff is calculated using:

:contentReference[oaicite:0]{index=0}

Where:

- **t** = Time to takeoff
- **v** = Takeoff velocity
- **a** = Acceleration

---

### Takeoff Distance

The takeoff distance is calculated using:

:contentReference[oaicite:1]{index=1}

Where:

- **d** = Takeoff distance
- **a** = Acceleration
- **t** = Takeoff time

---

## Example Calculation

### Aircraft: A-747

```text
Takeoff Velocity = 250 ft/s
Acceleration = 33.5 ft/s²
```

### Step 1: Calculate Time

```text
Time = Velocity ÷ Acceleration

Time = 250 ÷ 33.5

Time ≈ 7.46 seconds
```

### Step 2: Calculate Distance

```text
Distance = 0.5 × 33.5 × (7.46²)

Distance ≈ 932.84 feet
```

---

## Application Workflow

### Step 1

Launch the application.

### Step 2

Select an aircraft from the list.

```text
A-747
A-735
C-150
D-240
```

### Step 3

The application automatically:

- Retrieves aircraft specifications
- Calculates takeoff time
- Calculates takeoff distance
- Displays results

### Step 4

Review the generated performance report.

---

## Object-Oriented Concepts Demonstrated

### Encapsulation

The Aircraft class stores:

- Aircraft Name
- Takeoff Velocity
- Acceleration

### Computed Properties

The application uses calculated properties for:

- Takeoff Time
- Takeoff Distance

### Object Collections

Multiple Aircraft objects are created and stored in an array for selection and processing.

---

## Skills Demonstrated

- VB.NET Development
- Windows Forms Development
- Object-Oriented Programming
- Engineering Calculations
- Mathematical Modeling
- Event Handling
- Data Structures
- Desktop Application Development

---

## Learning Outcomes

This project demonstrates:

- Building engineering calculation software
- Working with formulas and equations
- Using object-oriented design
- Creating interactive desktop applications
- Implementing computed properties
- Managing collections of objects

---

## Real-World Applications

The concepts used in this project can be applied to:

- Aviation Planning Software
- Flight Simulation Systems
- Aircraft Performance Analysis
- Aerospace Engineering Tools
- Transportation Modeling Systems
- Engineering Calculation Applications

---

## Future Improvements

- Add more aircraft models
- Allow custom aircraft entry
- Metric and Imperial unit conversion
- Aircraft comparison mode
- Performance charts and graphs
- Export calculation reports
- Database integration
- Flight simulation enhancements

---

## Author

**Sizwe Ramokhali**

Comp Sci & IT Student | Software Developer

### Skills Demonstrated

- VB.NET Development
- Object-Oriented Design
- Mathematical Programming
- Engineering Calculations
- Event-Driven Programming
- Desktop Application Development
- Problem Solving
