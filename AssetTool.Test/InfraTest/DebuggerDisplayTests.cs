using NUnit.Framework;

namespace AssetTool.Test.InfraTest
{
    public class DebuggerDisplayTests : TestBase
    {
        [Test]
        [Description("Put the mouse over the variables to see the display")]
        public void DebuggerDisplay_Should_Succeed()
        {
            var boxSphereBounds3d = new FBoxSphereBounds3d { Origin = new() { X = 1, Y = 2, Z = 3 }, BoxExtent = new() { X = 10, Y = 20, Z = 30 }, SphereRadius = 1 };
            var boxSphereBounds3f = new FBoxSphereBounds3f { Origin = new() { X = 1, Y = 2, Z = 3 }, BoxExtent = new() { X = 10, Y = 20, Z = 30 }, SphereRadius = 1 };
            var boxSphereBounds = new FBoxSphereBounds { Origin = new() { X = 1, Y = 2, Z = 3 }, BoxExtent = new() { X = 10, Y = 20, Z = 30 }, SphereRadius = 1 };

            var box2d = new FBox2d { Min = new() { X = 1, Y = 2 }, Max = new() { X = 10, Y = 20 }, IsValid = 1 };
            var box2f = new FBox2f { Min = new() { X = 1, Y = 2 }, Max = new() { X = 10, Y = 20 }, IsValid = 1 };
            var box2D = new FBox2D { Min = new() { X = 1, Y = 2 }, Max = new() { X = 10, Y = 20 }, IsValid = 1 };

            var box3d = new FBox3d { Min = new() { X = 1, Y = 2, Z = 3 }, Max = new() { X = 10, Y = 20, Z = 30 }, IsValid = 1 };
            var box3f = new FBox3f { Min = new() { X = 1, Y = 2, Z = 3 }, Max = new() { X = 10, Y = 20, Z = 30 }, IsValid = 1 };
            var box = new FBox { Min = new() { X = 1, Y = 2 }, Max = new() { X = 10, Y = 20 }, IsValid = 1 };

            var color = new FColor { R = 1, G = 2, B = 3, A = 4 };

            var intPoint = new FIntPoint { X = 1, Y = 2 };

            var linearColor = new FLinearColor { R = 1, G = 2, B = 3, A = 4 };

            var plane4d = new FPlane4d { X = 1, Y = 2, Z = 3, W = 4 };
            var plane4f = new FPlane4f { X = 1, Y = 2, Z = 3, W = 4 };
            var plane = new FPlane { X = 1, Y = 2, Z = 3, W = 4 };

            var quat4d = new FQuat4d { X = 1, Y = 2, Z = 3, W = 4 };
            var quat4f = new FQuat4f { X = 1, Y = 2, Z = 3, W = 4 };
            var quat = new FQuat { X = 1, Y = 2, Z = 3, W = 4 };

            var rotator3d = new FRotator3d { Roll = 1, Pitch = 2, Yaw = 3 };
            var rotator3f = new FRotator3f { Roll = 1, Pitch = 2, Yaw = 3 };
            var rotator = new FRotator { Roll = 1, Pitch = 2, Yaw = 3 };

            var transform3d = new FTransform3d { Translation = new() { X = 1, Y = 2, Z = 3 }, Rotation = new() { X = 10, Y = 20, Z = 30, W = 40 }, Scale3D = new() { X = 100, Y = 200, Z = 300 } };
            var transform3f = new FTransform3f { Translation = new() { X = 1, Y = 2, Z = 3 }, Rotation = new() { X = 10, Y = 20, Z = 30, W = 40 }, Scale3D = new() { X = 100, Y = 200, Z = 300 } };
            var transform = new FTransform { Translation = new() { X = 1, Y = 2, Z = 3 }, Rotation = new() { X = 10, Y = 20, Z = 30, W = 40 }, Scale3D = new() { X = 100, Y = 200, Z = 300 } };

            var vector2d = new FVector2d { X = 1, Y = 2 };
            var vector2f = new FVector2f { X = 1, Y = 2 };
            var vector2D = new FVector2D { X = 1, Y = 2 };

            var vector3d = new FVector3d { X = 1, Y = 2, Z = 3 };
            var vector3f = new FVector3f { X = 1, Y = 2, Z = 3 };
            var vector3 = new FVector3 { X = 1, Y = 2, Z = 3 };

            var vector4d = new FVector4d { X = 1, Y = 2, Z = 3, W = 4 };
            var vector4f = new FVector4f { X = 1, Y = 2, Z = 3, W = 4 };
            var vector4 = new FVector4 { X = 1, Y = 2, Z = 3, W = 4 };

            var intVector2 = new FIntVector2 { X = 1, Y = 2 };

            var uintVector2 = new FUIntVector2 { X = 1, Y = 2 };
            var int64Vector2 = new FInt64Vector2 { X = 1, Y = 2 };
            var uint64Vector2 = new FUInt64Vector2 { X = 1, Y = 2 };

            var intVector3 = new FIntVector3 { X = 1, Y = 2, Z = 3 };
            var uintVector3 = new FUIntVector3 { X = 1, Y = 2, Z = 3 };
            var int64Vector3 = new FInt64Vector3 { X = 1, Y = 2, Z = 3 };
            var uint64Vector3 = new FUInt64Vector3 { X = 1, Y = 2, Z = 3 };

            var intVector4 = new FIntVector4 { X = 1, Y = 2, Z = 3, W = 4 };
            var uintVector4 = new FUIntVector4 { X = 1, Y = 2, Z = 3, W = 4 };
            var int64Vector4 = new FInt64Vector4 { X = 1, Y = 2, Z = 3, W = 4 };
            var uint64Vector4 = new FUInt64Vector4 { X = 1, Y = 2, Z = 3, W = 4 };

            var matrix44d = new FMatrix44d { M11 = 1, M12 = 2, M13 = 3, M14 = 4, M21 = 5, M22 = 6, M23 = 7, M24 = 8, M31 = 9, M32 = 10, M33 = 11, M34 = 12, M41 = 13, M42 = 14, M43 = 15, M44 = 16 };
            var matrix44f = new FMatrix44f { M11 = 1, M12 = 2, M13 = 3, M14 = 4, M21 = 5, M22 = 6, M23 = 7, M24 = 8, M31 = 9, M32 = 10, M33 = 11, M34 = 12, M41 = 13, M42 = 14, M43 = 15, M44 = 16 };
            var matrix = new FMatrix { M11 = 1, M12 = 2, M13 = 3, M14 = 4, M21 = 5, M22 = 6, M23 = 7, M24 = 8, M31 = 9, M32 = 10, M33 = 11, M34 = 12, M41 = 13, M42 = 14, M43 = 15, M44 = 16 };

            var floatRange = new FFloatRange { LowerBound = new() { Type = ERangeBoundType.Inclusive, Value = 1 }, UpperBound = new() { Type = ERangeBoundType.Inclusive, Value = 2 } };
            var doubleRange = new FDoubleRange { LowerBound = new() { Type = ERangeBoundType.Inclusive, Value = 1 }, UpperBound = new() { Type = ERangeBoundType.Inclusive, Value = 2 } };
            var int32Range = new FInt32Range { LowerBound = new() { Type = ERangeBoundType.Inclusive, Value = 1 }, UpperBound = new() { Type = ERangeBoundType.Inclusive, Value = 2 } };
            var frameNumberRange = new FFrameNumberRange { LowerBound = new() { Type = ERangeBoundType.Inclusive, Value = new() { Value = 1 } }, UpperBound = new() { Type = ERangeBoundType.Inclusive, Value = new() { Value = 2 } } };

            var ray3d = new FRay3d { Origin = new() { X = 1, Y = 2, Z = 3 }, Direction = new() { X = 10, Y = 20, Z = 30 } };
            var ray3f = new FRay3f { Origin = new() { X = 1, Y = 2, Z = 3 }, Direction = new() { X = 10, Y = 20, Z = 30 } };
            var ray = new FRay { Origin = new() { X = 1, Y = 2, Z = 3 }, Direction = new() { X = 10, Y = 20, Z = 30 } };

            var shVectorRGB3 = new FSHVectorRGB3 { R = new() { v = [1, 2, 3, 4, 5, 6, 7, 8, 9] }, G = new() { v = [1, 2, 3, 4, 5, 6, 7, 8, 9] }, B = new() { v = [1, 2, 3, 4, 5, 6, 7, 8, 9] } };
            var shVectorRGB2 = new FSHVectorRGB2 { R = new() { v = [1, 2, 3, 4] }, G = new() { v = [1, 2, 3, 4] }, B = new() { v = [1, 2, 3, 4] } };
        }
    }
}
