// See https://aka.ms/new-console-template for more information

/*
 * Convert the interface of a class into another interface that clients expect.
 * The adapter pattern lets classes work together that could not otherwise because
 * of incompatible interfaces
 */

LegacyRectangle legacyRectangle = new LegacyRectangle(6, 2, 5, 5);

IRectangle rectangle = new LegacyRectangleAdapter(legacyRectangle);

// The Game Engine client cannot directly use the LegacyRectangle methods,
// so it should use a LegacyRectangleAdapter to access the LegacyRectangle functionality.

GameEngine engine = new GameEngine(rectangle);

engine.CentreRectange();