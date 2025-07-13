namespace AssetTool
{
    [JsonAsset("PackedLevelActor")]
    public class APackedLevelActor : ALevelInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}