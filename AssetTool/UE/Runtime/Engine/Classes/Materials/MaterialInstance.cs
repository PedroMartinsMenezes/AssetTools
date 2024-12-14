using System.Text.Json;

namespace AssetTool
{
    [JsonAsset("MaterialInstanceEditorOnlyData")]
    public class UMaterialInstanceEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialInstance")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
        public new UScriptStruct Struct;
        public bool bHasStaticPermutationResource;
        public FStaticParameterSet StaticParameters_DEPRECATED;
        public Int32 NumLoadedResources;
        public FBool bOverrideBaseProperties_DEPRECATED;
        public FBool bHasPropertyOverrides;
        public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;

        [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.MaterialSavedCachedData))
            {
                transfer.Move(ref bSavedCachedData);
            }
            if (bSavedCachedData?.Value == true)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer);
            }
            bHasStaticPermutationResource = Parent() && (HasStaticParameters || HasOverridenBaseProperties);
            if (bHasStaticPermutationResource)
            {
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS))
                {
                    if (!Supports.CustomVer(FRenderingObjectVersion.Enums.MaterialAttributeLayerParameters))
                    {
                        StaticParameters_DEPRECATED ??= new();
                        StaticParameters_DEPRECATED.Move(transfer);
                    }
                    SerializeInlineShaderMaps(transfer);
                }
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_MATERIAL_INSTANCE_BASE_PROPERTY_OVERRIDES))
            {
                if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_FIX_MATERIAL_PROPERTY_OVERRIDE_SERIALIZE))
                {
                    transfer.Move(ref bOverrideBaseProperties_DEPRECATED);
                    transfer.Move(ref bHasPropertyOverrides);
                    if (bHasPropertyOverrides)
                    {
                        BasePropertyOverrides ??= new();
                        BasePropertyOverrides.Move(transfer);
                    }
                }
            }

            return this;
        }

        private static bool HasOverridenBaseProperties => true;

        private static bool HasStaticParameters => true;

        private bool Parent()
        {
            bool result = Tags.Exists(x =>
            {
                if (x is Dictionary<string, object> dict)
                {
                    return dict.Any(x => x.Key.Contains("bHasStaticPermutationResource") && (bool)x.Value);
                }
                else if (x is FPropertyTag tag)
                {
                    return tag.Name is { } && tag.Name.Value.Contains("bHasStaticPermutationResource") && int.Parse(tag.Value.ToString()) == 1;
                }
                else if (x is JsonElement elem)
                {
                    return elem.EnumerateObject().Any(y => y.Name.Contains("bHasStaticPermutationResource") && y.Value.ToString() == "True");
                }
                else
                {
                    return false;
                }
            });
            return result;
        }

        private void SerializeInlineShaderMaps(Transfer transfer)
        {
            transfer.Move(ref NumLoadedResources);
            if (NumLoadedResources > 0)
            {
                throw new NotImplementedException();
            }
        }
    }
}