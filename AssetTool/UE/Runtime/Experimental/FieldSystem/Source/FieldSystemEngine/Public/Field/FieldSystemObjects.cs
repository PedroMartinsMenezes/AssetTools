namespace AssetTool
{
    [JsonAsset("FieldSystemMetaData")]
    public class UFieldSystemMetaData : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldSystemMetaDataIteration")]
    public class UFieldSystemMetaDataIteration : UFieldSystemMetaData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldSystemMetaDataProcessingResolution")]
    public class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldSystemMetaDataFilter")]
    public class UFieldSystemMetaDataFilter : UFieldSystemMetaData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldNodeBase")]
    public class UFieldNodeBase : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldNodeInt")]
    public class UFieldNodeInt : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldNodeFloat")]
    public class UFieldNodeFloat : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FieldNodeVector")]
    public class UFieldNodeVector : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UniformInteger")]
    public class UUniformInteger : UFieldNodeInt
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RadialIntMask")]
    public class URadialIntMask : UFieldNodeInt
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UniformScalar")]
    public class UUniformScalar : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaveScalar")]
    public class UWaveScalar : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RadialFalloff")]
    public class URadialFalloff : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlaneFalloff")]
    public class UPlaneFalloff : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BoxFalloff")]
    public class UBoxFalloff : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NoiseField")]
    public class UNoiseField : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UniformVector")]
    public class UUniformVector : UFieldNodeVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RadialVector")]
    public class URadialVector : UFieldNodeVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RandomVector")]
    public class URandomVector : UFieldNodeVector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OperatorField")]
    public class UOperatorField : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToIntegerField")]
    public class UToIntegerField : UFieldNodeInt
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToFloatField")]
    public class UToFloatField : UFieldNodeFloat
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CullingField")]
    public class UCullingField : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReturnResultsTerminal")]
    public class UReturnResultsTerminal : UFieldNodeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}