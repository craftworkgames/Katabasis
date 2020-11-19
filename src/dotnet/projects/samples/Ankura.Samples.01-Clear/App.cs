// Copyright (c) Craftwork Games. All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory for full license information.

using System;
using Microsoft.Xna.Framework;

namespace Ankura.Samples.Clear
{
    public class App : Game
    {
        private Vector4 _clearColor;

        public App()
        {
            Window.Title = "DNA Samples: Clear";

            // XNA crap: strong reference is put in the Services; no, you should not use Services
            new GraphicsDeviceManager(this);

            _clearColor = Color.Red.ToVector4();
        }

        protected override void Draw(GameTime gameTime)
        {
            _clearColor.Y = _clearColor.Y > 1.0f ? 0.0f : _clearColor.Y + 0.01f;

            // Clear the default framebuffer with the specified color
            GraphicsDevice.Clear(new Color(_clearColor));
        }
    }
}