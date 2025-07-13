namespace AssetTool
{
    [JsonAsset("AnimNextComponent")]
    public class UAnimNextComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}