# ELMS – Employee Leave Management System

> **Zero → Hero C# / .NET Learning Repository**
> Built step‑by‑step to master **C#, .NET, EF Core, OOP, Auth, DI, Middleware & DBMS** for **6+ years backend interviews**.

---

## 📌 Purpose of This Repository

This repository is **not just a project**.
It is a **guided engineering journey** designed to:

* Learn **C# and .NET sequentially (from fundamentals to advanced)**
* Apply **every concept immediately in a real enterprise‑style project**
* Build **strong interview explanations**, not just working code
* Avoid random learning and topic jumping

> ⚠️ Rule: **No topic is learned without applying it to ELMS**.

---

## 🏗️ What We Are Building

### **ELMS – Employee Leave Management System**

A backend system used by organizations to:

* Manage employees
* Apply for leaves
* Approve / reject leaves
* Enforce leave policies
* Secure APIs using authentication & authorization
* Maintain audit logs

This system evolves gradually as we learn new topics.

---

## 🧠 Target Audience

* Developers preparing for **5–8 years .NET backend interviews**
* Developers who know syntax but want **deep understanding**
* Engineers who want to think like **senior backend developers**

---

## 🧱 Final Domain Vision (End State)

```
Employee (Base Class)
 ├── Admin
 ├── Manager
 └── Staff

Department
LeaveType
LeavePolicy
LeaveRequest
AuditLog
```

Each entity exists to **apply a specific C# / .NET concept**.

---

## 🔐 Authentication & Authorization (Planned)

* JWT‑based authentication
* Claims‑based identity
* Role‑based authorization
* Policy‑based authorization
* Resource‑based access checks

> Authorization logic will be implemented **incrementally**, not all at once.

---

## 🧭 Learning Philosophy (IMPORTANT)

We follow **this strict rule**:

> **Foundation → OOP → Framework → Persistence → Advanced Internals**

### ❌ What We Will NOT Do

* Jump to EF before understanding LINQ
* Jump to DI before understanding interfaces
* Jump to middleware before request pipeline
* Jump to reflection before inheritance

---

## 📚 COMPLETE LEARNING ROADMAP (ZERO → HERO)

Below is the **exact order** in which topics will be learned and applied.

---

### 🔹 PHASE 0 – CLR & Memory Fundamentals

**Goal:** Understand how C# really works under the hood.

Topics:

* CLR, JIT & IL
* Stack vs Heap
* Value vs Reference types
* Object lifecycle
* Garbage Collection (basics)

ELMS Impact:

* Understanding object creation & destruction
* Preventing memory mistakes

---

### 🔹 PHASE 1 – Classes & Constructors

Topics:

* Classes & objects
* Fields vs properties
* Constructors
* Constructor overloading
* Constructor chaining (`this`, `base`)

ELMS Impact:

* Employee creation rules
* Initial leave balance setup

---

### 🔹 PHASE 2 – Encapsulation (OOP Pillar 1)

Topics:

* Access modifiers
* Private setters
* Data protection
* Invariant enforcement

ELMS Impact:

* Leave balance cannot be changed directly

---

### 🔹 PHASE 3 – Inheritance (OOP Pillar 2)

Topics:

* Base vs derived classes
* Virtual & override
* Abstract classes
* Sealed classes

ELMS Impact:

* Admin, Manager, Staff inheritance model

---

### 🔹 PHASE 4 – Polymorphism (OOP Pillar 3)

Topics:

* Method overloading
* Method overriding
* Runtime vs compile‑time polymorphism

ELMS Impact:

* Role‑specific leave approval logic

---

### 🔹 PHASE 5 – Abstraction (OOP Pillar 4)

Topics:

* Interfaces
* Dependency inversion
* Composition over inheritance

ELMS Impact:

* Leave services
* Notification services

---

### 🔹 PHASE 6 – Delegates & Events

Topics:

* Delegates
* Multicast delegates
* Func / Action / Predicate
* Events
* Event memory leak pitfalls

ELMS Impact:

* Leave applied / approved events

---

### 🔹 PHASE 7 – Collections, LINQ & IQueryable

Topics:

* Collections deep dive
* LINQ internals
* Deferred execution
* IEnumerable vs IQueryable
* Expression trees

ELMS Impact:

* Leave reports
* Optimized queries

---

### 🔹 PHASE 8 – Async Programming

Topics:

* async / await
* Task vs Thread
* Deadlocks
* ConfigureAwait

ELMS Impact:

* Non‑blocking leave workflows

---

### 🔹 PHASE 9 – ASP.NET Core Fundamentals

Topics:

* Request pipeline
* Controllers
* Filters
* Model binding

ELMS Impact:

* Leave management APIs

---

### 🔹 PHASE 10 – Dependency Injection (Deep Dive)

Topics:

* DI container
* AddSingleton
* AddScoped
* AddTransient
* Lifetime pitfalls

ELMS Impact:

* Correct service lifetimes

---

### 🔹 PHASE 11 – Middleware

Topics:

* Built‑in middleware
* Custom middleware
* Exception handling
* Logging pipeline

ELMS Impact:

* Global logging & error handling

---

### 🔹 PHASE 12 – Authentication & Authorization

Topics:

* Authentication flow
* JWT
* Claims
* Role‑based authorization
* Policy‑based authorization

ELMS Impact:

* Secured APIs

---

### 🔹 PHASE 13 – EF Core (Basic → Advanced)

Topics:

* DbContext
* Relationships
* Migrations
* Tracking vs NoTracking
* Transactions
* Concurrency control

ELMS Impact:

* Persistent leave data

---

### 🔹 PHASE 14 – Database Internals

Topics:

* Indexes
* Joins
* Stored Procedures
* Isolation levels
* Deadlocks

ELMS Impact:

* Performance‑optimized queries

---

### 🔹 PHASE 15 – Reflection & Metadata

Topics:

* Reflection
* Attributes
* Metadata

ELMS Impact:

* Attribute‑based authorization

---

### 🔹 PHASE 16 – Enterprise Features

Topics:

* Caching
* Background jobs
* Audit logging
* Multi‑tenancy basics
* Sharding concepts

ELMS Impact:

* Production‑ready backend

---

## 🛑 Repository Rules

* Each phase has its **own folder / branch**
* No skipping phases
* Every commit maps to **one learning concept**
* README updated as learning progresses

---

## ✅ Final Outcome

By completing this repository, you will:

* Think like a **senior .NET backend engineer**
* Confidently answer **deep interview questions**
* Understand **why frameworks work the way they do**
* Have one **flagship project** to discuss in interviews

---

> 🔥 This repository is a **learning system**, not just source code.

---

## 🚀 Next Step

We begin with:

**PHASE 0 – CLR, Memory & Object Lifecycle**

(First code comes only after the mental model is clear.)
