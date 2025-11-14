namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultEditorPipelineActor")]
    public class AMetaHumanDefaultEditorPipelineActor : AMetaHumanCharacterEditorActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}