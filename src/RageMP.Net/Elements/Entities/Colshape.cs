using System;
using System.Numerics;
using RageMP.Net.Enums;
using RageMP.Net.Interfaces;
using RageMP.Net.Native;

namespace RageMP.Net.Elements.Entities
{
    internal class Colshape : Entity, IColshape
    {
        public ColshapeType ShapeType => (ColshapeType)Rage.Colshape.Colshape_GetShapeType(NativePointer);

        internal Colshape(IntPtr nativePointer, Plugin plugin) : base(nativePointer, plugin, EntityType.Colshape)
        {
        }

        public bool IsPointWhithin(Vector3 position)
        {
            return Rage.Colshape.Colshape_IsPointWithin(NativePointer, position);
        }
    }
}