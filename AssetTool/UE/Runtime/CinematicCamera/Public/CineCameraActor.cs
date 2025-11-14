namespace AssetTool
{
    [JsonAsset("CineCameraActor")]
    public class ACineCameraActor : ACameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}