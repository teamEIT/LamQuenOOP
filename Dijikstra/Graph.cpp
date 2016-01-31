#include "Graph.h"


// Constructor
Graph::Graph()
{
}
Graph::Graph(int size)
{
	int i, j;
	// Khoi tao so dinh cua do thi
	if (size < 2)
		n = 2;
	else
		n = size;

	// Tao cac dinh
	edge = new int*[n];
	for (i = 0; i < n; i++)
		edge[i] = new int[n];
	// Mac dinh giua cac dinh khong co ket noi voi nhau
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			edge[i][j] = 0;
}
// Destructor
Graph::~Graph()
{
	int i;
	for (i = 0; i < n; ++i)
		delete[] edge[i];
	delete[] edge;
}
// Phuong thuc
// Kiem tra hai dinh co ke nhau khong
bool Graph::isConnected(int x, int y)
{
	if (edge[x - 1][y - 1] == 1)
		return true;
	return false;
}

// Them canh noi dinh x va dinh y
void Graph::addEdge(int x, int y)
{
	if (x < 1 || x > n || y < 1 || y > n)
		return;
	edge[x - 1][y - 1] = edge[y - 1][x - 1] = 1;
}

// Thuat toan
void Graph::depthFirstSearch(int s, int g)
{
	// Kiem tra start va goal co thuoc graph khong 
	if (s < 0 || s > n || g < 0 || g > n)
	{
		cout << "Can not traverse this graph with this request." << endl;
		return;
	}
	// Tao tap open chua cac dinh s cho xet
	stack <int> open;
	bool *close = new bool[n];
	int i;
	int p;

	// Mac dinh cac dinh chua duoc duyet
	for (i = 0; i < n; i++)
		close[i] = false;

	// Dua goc s vao stack open chuan bi duyet
	open.push(s);
	printf("With Depth first Search , we have vertex(s):\n");
	//
	while (!open.empty())
	{
		// Lay 1 dinh ra khoi open tro thanh dinh dang xet
		do
		{
			if (open.empty())
				return;
			p = open.top();
			open.pop();
		} while (close[p - 1] == true);
		// In ra dinh dang xet
		cout << p << "\t";
		// Da dyet xong p
		close[p - 1] = true;

		// Ket thuc duyet khi da tim ra kq
		if (p == g)
			return;
		// Tim dinh ke dinh dang xet
		for (i = 1; i <= n; i++)
		{
			// Xet xem co ke nhau khong
			if (isConnected(p, i) && !close[i - 1])
			{
				open.push(i);
			}
		}
	}
	
	cout << "\n" << endl;
	delete[] close;
}