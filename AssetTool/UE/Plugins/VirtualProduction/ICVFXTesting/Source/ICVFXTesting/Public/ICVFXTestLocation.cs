namespace AssetTool
{
    [JsonAsset("ICVFXTestLocation")]
    public class AICVFXTestLocation : ACameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}