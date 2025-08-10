namespace AssetTool
{
    [JsonAsset("MetaHumanDefaultEditorPipelineActor")]
    public class AMetaHumanDefaultEditorPipelineActor : AMetaHumanCharacterEditorActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}