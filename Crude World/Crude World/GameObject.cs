using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Crude_World
{
    public abstract class GameObject
    {
        #region Properties
        public Chunk currentChunk
        { get; set; }

        public Vector2 Position
        { get; set; }
        #endregion

        #region Constructor

        #endregion

        #region Public Functions

        public abstract void Draw(Camera camera);
        #endregion

        #region Private Functions

        #endregion
    }
}
