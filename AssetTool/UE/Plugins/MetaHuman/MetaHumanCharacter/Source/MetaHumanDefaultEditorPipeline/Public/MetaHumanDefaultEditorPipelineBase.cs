namespace AssetTool
{
    [JsonAsset("LODBakingUtility")]
    public class ULODBakingUtility : UEditorUtilityObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanMaterialBakingSettings")]
    public class UMetaHumanMaterialBakingSettings : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanDefaultEditorPipelineBase")]
    public class UMetaHumanDefaultEditorPipelineBase : UMetaHumanCollectionEditorPipeline
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}