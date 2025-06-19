namespace AssetTool
{
    [JsonAsset("EditorUtilityCamera")]
    public class AEditorUtilityCamera : ACameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}