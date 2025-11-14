namespace AssetTool
{
    [JsonAsset("AnimNextComponent")]
    public class UAnimNextComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}