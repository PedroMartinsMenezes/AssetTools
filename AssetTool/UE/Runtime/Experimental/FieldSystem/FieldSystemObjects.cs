namespace AssetTool
{
    [JsonAsset("FieldSystemMetaData")] public class UFieldSystemMetaData : UActorComponent { }
    [JsonAsset("FieldSystemMetaDataIteration")] public class UFieldSystemMetaDataIteration : UFieldSystemMetaData { }
    [JsonAsset("FieldSystemMetaDataProcessingResolution")] public class UFieldSystemMetaDataProcessingResolution : UFieldSystemMetaData { }
    [JsonAsset("FieldSystemMetaDataFilter")] public class UFieldSystemMetaDataFilter : UFieldSystemMetaData { }
    [JsonAsset("FieldNodeBase")] public class UFieldNodeBase : UActorComponent { }
    [JsonAsset("FieldNodeInt")] public class UFieldNodeInt : UFieldNodeBase { }
    [JsonAsset("FieldNodeFloat")] public class UFieldNodeFloat : UFieldNodeBase { }
    [JsonAsset("FieldNodeVector")] public class UFieldNodeVector : UFieldNodeBase { }
    [JsonAsset("niformInteger")] public class UUniformInteger : UFieldNodeInt { }
    [JsonAsset("RadialIntMask")] public class URadialIntMask : UFieldNodeInt { }
    [JsonAsset("niformScalar")] public class UUniformScalar : UFieldNodeFloat { }
    [JsonAsset("WaveScalar")] public class UWaveScalar : UFieldNodeFloat { }
    [JsonAsset("RadialFalloff")] public class URadialFalloff : UFieldNodeFloat { }
    [JsonAsset("PlaneFalloff")] public class UPlaneFalloff : UFieldNodeFloat { }
    [JsonAsset("BoxFalloff")] public class UBoxFalloff : UFieldNodeFloat { }
    [JsonAsset("NoiseField")] public class UNoiseField : UFieldNodeFloat { }
    [JsonAsset("niformVector")] public class UUniformVector : UFieldNodeVector { }
    [JsonAsset("RadialVector")] public class URadialVector : UFieldNodeVector { }
    [JsonAsset("RandomVector")] public class URandomVector : UFieldNodeVector { }
    [JsonAsset("OperatorField")] public class UOperatorField : UFieldNodeBase { }
    [JsonAsset("ToIntegerField")] public class UToIntegerField : UFieldNodeInt { }
    [JsonAsset("ToFloatField")] public class UToFloatField : UFieldNodeFloat { }
    [JsonAsset("CullingField")] public class UCullingField : UFieldNodeBase { }
    [JsonAsset("ReturnResultsTerminal")] public class UReturnResultsTerminal : UFieldNodeBase { }
}
