using System.Diagnostics.Metrics;

class GraphicPrimitive : def __init__(self, x, y):
        self.x = x        self.y = y
    def draw(self):
        pass
    def move(self, x, y):        self.x += x
        self.y += y
class Circle(GraphicPrimitive) : def __init__(self, x, y, radius):
        super().__init__(x, y)        self.radius = radius
    def draw(self):
        # Implement circle drawing        pass
    def scale(self, factor):
        self.radius *= factor
class Rectangle(GraphicPrimitive) : def __init__(self, x, y, width, height):
        super().__init__(x, y)        self.width = width
        self.height = height
    def draw(self):        # Implement rectangle drawing
        pass
    def scale(self, factor):        self.width *= factor
        self.height *= factor
class Triangle(GraphicPrimitive) : def __init__(self, x, y, side1, side2, side3):
        super().__init__(x, y)        self.side1 = side1
        self.side2 = side2        self.side3 = side3
    def draw(self):
        # Implement triangle drawing        pass
    def scale(self, factor):
        self.side1 *= factor
        self.side2 *= factor        self.side3 *= factor
class Group(GraphicPrimitive) :
    def __init__(self, x, y):        super().__init__(x, y)
        self.members = []
    def add_member(self, member):        self.members.append(member)
    def draw(self):
        # Implement drawing for the entire group        pass
    def move(self, x, y):
        super().move(x, y)        for member in self.members:
            member.move(x, y)
