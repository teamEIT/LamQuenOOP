#include "Graph.h"

int main()
{
	Graph graph(8);
	graph.addEdge(1, 2);
	graph.addEdge(1, 3);
	graph.addEdge(1, 4);
	graph.addEdge(1, 5);
	graph.addEdge(2, 6);
	graph.addEdge(3, 4);
	graph.addEdge(3, 8);
	graph.addEdge(4, 8);
	graph.addEdge(5, 8);
	graph.addEdge(6, 7);
	graph.addEdge(6, 8);
	// Duyet bang Depth First Search
	graph.depthFirstSearch(1, 4);
	system("pause");
	return 0;
}
