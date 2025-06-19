namespace AssetTool
{
    [JsonAsset("CineCameraActor")]
    public class ACineCameraActor : ACameraActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}