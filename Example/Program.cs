// See https://aka.ms/new-console-template for more information
using Hexa.NET.Box2D;
using System.Numerics;

int consoleWidth = Console.WindowWidth;
int consoleHeight = Console.WindowHeight;

B2WorldDef worldDef = Box2D.DefaultWorldDef();
worldDef.Gravity = new(0, -9.8f);

B2WorldId world = Box2D.CreateWorld(ref worldDef);

// Step 3: Create the ground body (static body)
B2BodyDef groundBodyDef = Box2D.DefaultBodyDef();
groundBodyDef.Position = new Vector2(0.0f, -10.0f); // Position the ground at y = -10
groundBodyDef.Type = B2BodyType.StaticBody; // Static body
B2BodyId groundBody = Box2D.CreateBody(world, ref groundBodyDef);

// Step 4: Define the shape for the ground
B2ShapeDef groundShapeDef = Box2D.DefaultShapeDef();
groundShapeDef.Restitution = .8f;
B2Polygon boxShape = Box2D.MakeBox(50.0f, 10.0f); // Large box for the ground
Box2D.CreatePolygonShape(groundBody, ref groundShapeDef, ref boxShape);

// Step 5: Create a dynamic body (falling box)
B2BodyDef boxBodyDef = Box2D.DefaultBodyDef();
boxBodyDef.Type = B2BodyType.DynamicBody;
boxBodyDef.Position = new Vector2(0.0f, 10); // Start above the ground
boxBodyDef.LinearVelocity = new(5, 0);

B2BodyId boxBody = Box2D.CreateBody(world, ref boxBodyDef);

// Step 6: Define the shape and properties for the dynamic body
B2ShapeDef boxShapeDef = Box2D.DefaultShapeDef();
B2Polygon boxShape2 = Box2D.MakeBox(1.0f, 1.0f); // 2x2 box
boxShapeDef.Density = 1.0f;
boxShapeDef.Friction = 0.0f;
Box2D.CreatePolygonShape(boxBody, ref boxShapeDef, ref boxShape2);

// Simulation parameters
float timeStep = 1.0f / 60.0f; // 60 frames per second
int substepCount = 60;

// Step 7: Run the simulation loop
for (int step = 0; step < 1000; ++step)
{
    // Step the physics world
    Box2D.WorldStep(world, timeStep, substepCount);

    // Get the position and angle of the dynamic body (falling box)
    B2Transform transform = Box2D.BodyGetTransform(boxBody);
    Vector2 position = transform.P;
    B2Rot rotation = transform.Q;

    float angle = (float)Math.Atan2(rotation.S, rotation.C); // Convert from sine and cosine to radians

    // Calculate console X and Y positions
    int consoleX = (int)(position.X);
    int consoleY = (int)(-position.Y + consoleHeight / 2); // Adjust Y to ensure it stays positive

    // Clamp X and Y to be within the console window
    consoleX = Math.Clamp(consoleX, 0, consoleWidth - 1);
    consoleY = Math.Clamp(consoleY, 0, consoleHeight - 1);

    // Clear the console and draw the simulation
    Console.SetCursorPosition(consoleX, consoleY);
    Console.Write("*"); // Represent the box as a pair of square brackets
    Console.SetCursorPosition(0, 20);
    Console.WriteLine($"Step: {step}, Box Position: ({position.X:0.00}, {position.Y:0.00}), Angle: {angle:0.00}");

    // Wait a bit before the next simulation step
    Thread.Sleep((int)(timeStep * 1000));
}

// Clean up the world
Box2D.DestroyWorld(world);