namespace AssetTool
{
    [JsonAsset("DatasmithSceneElement")]
    public class UDatasmithSceneElement : UDatasmithSceneElementBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithStaticMeshBlueprintLibrary")]
    public class UDatasmithStaticMeshBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}