namespace AssetTool
{
    [JsonAsset("EditorUtilityActor")]
    public class AEditorUtilityActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}