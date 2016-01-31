#pragma once
#include <iostream>
#include <stack>

using namespace std;

class Graph
{
private:
	// Size
	int n; 
	int **edge;
public:
	// Constructor
	Graph();
	Graph(int);
	~Graph();
	bool isConnected(int, int);
	void addEdge(int , int );
	void depthFirstSearch(int, int);
};

