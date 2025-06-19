namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceActorComponent")]
    public class UNiagaraDataInterfaceActorComponent : UNiagaraDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}