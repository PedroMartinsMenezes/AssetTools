namespace AssetTool
{
    [JsonAsset("ICVFXTestLocation")]
    public class AICVFXTestLocation : ACameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}