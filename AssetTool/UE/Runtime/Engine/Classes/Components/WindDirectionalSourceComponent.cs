namespace AssetTool
{
    [JsonAsset("WindDirectionalSourceComponent")]
    public class UWindDirectionalSourceComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}