namespace AssetTool
{
    [JsonAsset("NiagaraSequencerTrackFilter")]
    public class UNiagaraSequencerTrackFilter : USequencerTrackFilterExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}