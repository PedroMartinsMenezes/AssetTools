namespace AssetTool
{
    [JsonAsset("NiagaraComponent")]
    public class UNiagaraComponent : UFXSystemComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}