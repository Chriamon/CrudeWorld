using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Crude_World
{
    public class Camera
    {
        #region Properties
        /// <summary>
        /// The viewing rectangle for our camera, this is what will be drawn on screen. All objects are drawn on screen
        /// relative to their location on this rectangle.
        /// </summary>
        public Rectangle ViewingRectangle
        { get; set; }

        /// <summary>
        /// A rectangle of where we should begin drawing all game objects, this will be slightly larger than the
        /// viewing rectangle by a scaling.
        /// </summary>
        public Rectangle DrawingRectangle
        { get; set; }

        /// <summary>
        /// The object representing the centered chunk, allowing objects on different chunks to know draw locations.
        /// </summary>
        public Chunk CenterChunk
        { get; set; }

        #endregion

        #region Constructor

        #endregion

        #region Public Functions

        #endregion

        #region Private Functions

        #endregion
    }
}
