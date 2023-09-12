# StreamHub

Course Project for [Applications of Software Architecture for Big Data](https://www.coursera.org/learn/software-architecture-for-big-data-applications)

## Introduction

With StreamHub, you can effortlessly explore a vast catalog of popular shows and instantly discover which streaming service hosts which one. Say goodbye endless scrolling and subscription hopping to discover what shows are available to you.

StreamHub works by periodically scans the current popular shows, and find which streaming services they are available on. 

## Tech Stack
* Web Framework - aspnetcore
* Database - postgres
* Code Repository - GitHub
* Hosting - GCP
* Testing Suite - xunit
* Continuous Integration - GitHub Actions
* Continuous Deployment - Cloud Build

## Extenral Services
* get popular movies - https://developer.themoviedb.org/reference/movie-popular-list
* get streaming providers for a movie - https://developer.themoviedb.org/reference/movie-watch-providers