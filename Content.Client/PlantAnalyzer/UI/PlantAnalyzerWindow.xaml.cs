using Content.Shared.PlantAnalyzer;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Robust.Client.GameObjects;
using Robust.Client.ResourceManagement;
using FancyWindow = Content.Client.UserInterface.Controls.FancyWindow;

namespace Content.Client.PlantAnalyzer.UI;

[GenerateTypedNameReferences]
public sealed partial class PlantAnalyzerWindow : FancyWindow
{
    private readonly IEntityManager _entityManager;
    private readonly SpriteSystem _spriteSystem;
    private readonly IPrototypeManager _prototypes;
    private readonly IResourceCache _cache;

    public PlantAnalyzerWindow()
    {
        RobustXamlLoader.Load(this);

        var dependencies = IoCManager.Instance!;
        _entityManager = dependencies.Resolve<IEntityManager>();
        _spriteSystem = _entityManager.System<SpriteSystem>();
        _prototypes = dependencies.Resolve<IPrototypeManager>();
        _cache = dependencies.Resolve<IResourceCache>();
    }
    public void Populate()
    {
        Title = Loc.GetString("plant-analyzer-interface-title");
    }
}
