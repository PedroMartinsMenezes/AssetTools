namespace AssetTool
{
    [JsonAsset("EditorUtilityActor")]
    public class AEditorUtilityActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}