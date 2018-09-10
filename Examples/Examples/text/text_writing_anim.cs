

using Raylib;

using static Raylib.Raylib;



public partial class Examples

{

    /*******************************************************************************************
    *
    *   raylib [text] example - Text Writing Animation
    *
    *   This example has been created using raylib 1.4 (www.raylib.com)
    *   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
    *
    *   Copyright (c) 2016 Ramon Santamaria (@raysan5)
    *
    ********************************************************************************************/
    
    
    
    public static int text_writing_anim()
    {
        // Initialization
        //--------------------------------------------------------------------------------------
        int screenWidth = 800;
        int screenHeight = 450;
    
        InitWindow(screenWidth, screenHeight, "raylib [text] example - text writing anim");
        
        const char message[128] = "This sample illustrates a text writing\nanimation effect! Check it out! ;)";
        
        int framesCounter = 0;
        
        SetTargetFPS(60);
        //--------------------------------------------------------------------------------------
    
        // Main game loop
        while (!WindowShouldClose())    // Detect window close button or ESC key
        {
            // Update
            //----------------------------------------------------------------------------------
            if (IsKeyDown(KEY_SPACE)) framesCounter += 8;
            else framesCounter++;
            
            if (IsKeyPressed(KEY_ENTER)) framesCounter = 0;
            //----------------------------------------------------------------------------------
    
            // Draw
            //----------------------------------------------------------------------------------
            BeginDrawing();
    
                ClearBackground(RAYWHITE);
    
                DrawText(SubText(message, 0, framesCounter/10), 210, 160, 20, MAROON);
                
                DrawText("PRESS [ENTER] to RESTART!", 240, 260, 20, LIGHTGRAY);
                DrawText("PRESS [SPACE] to SPEED UP!", 239, 300, 20, LIGHTGRAY);
    
            EndDrawing();
            //----------------------------------------------------------------------------------
        }
    
        // De-Initialization
        //--------------------------------------------------------------------------------------   
        CloseWindow();        // Close window and OpenGL context
        //--------------------------------------------------------------------------------------
    
        return 0;
    }

}