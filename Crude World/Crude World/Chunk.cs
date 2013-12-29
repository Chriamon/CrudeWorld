using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Crude_World
{
    public class Chunk
    {
        #region Properties
        public Vector2 ChunkLocation
        { get; set; }

        public Tile[][] Tiles
        { get; set; }

        public const int ChunkSize = 100;

        List<GameObject> EnclosedObjects
        {get;set;}

        private SpriteBatch drawBatch;

        #endregion

        #region Constructor

        public Chunk(Vector2 chunkLocation)
        {
            //Load something here.
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// This function should eventually draw all objects in the camera's view to the spritebatch.
        /// </summary>
        /// <param name="currentCamera"></param>
        public void DrawScreen(Camera currentCamera)
        {
            for (int i = 0; i < Tiles.Length; i++)
            {
                for (int j = 0; j < Tiles[0].Length; j++)
                {
                    if (TileIsInCamera(Tiles[i][j]))
                    {
                        //Draw tile here.
                    }
                }
            }

            foreach (GameObject obj in EnclosedObjects)
            {
                obj.Draw();
            }
        }

        #endregion

        #region Private Functions
        private bool TileIsInCamera(Tile tile)
        {
            return true;
        }

        private bool GameObjectIsInCamera(GameObject gameObject)
        {
            return true;
        }

        #endregion
    }
}
