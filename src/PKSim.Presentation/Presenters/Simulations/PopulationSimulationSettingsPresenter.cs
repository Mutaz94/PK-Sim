using PKSim.Assets;
using PKSim.Core.Model;
using PKSim.Presentation.Views.Simulations;
using OSPSuite.Core.Domain.Services;
using OSPSuite.Core.Services;
using OSPSuite.Presentation.Presenters;
using OSPSuite.Utility.Extensions;
using ISimulationPersistableUpdater = PKSim.Core.Services.ISimulationPersistableUpdater;

namespace PKSim.Presentation.Presenters.Simulations
{
   public interface IPopulationSimulationSettingsPresenter : ISimulationOutputSelectionPresenter<PopulationSimulation>
   {
   }

   public class PopulationSimulationSettingsPresenter : SimulationOutputSelectionPresenter<IPopulationSimulationSettingsView, IPopulationSimulationSettingsPresenter, PopulationSimulation>, IPopulationSimulationSettingsPresenter
   {
      public PopulationSimulationSettingsPresenter(IPopulationSimulationSettingsView view, IQuantitySelectionPresenter quantitySelectionPresenter, ISimulationPersistableUpdater simulationPersistableUpdater, IProjectRetriever projectRetriever, IDialogCreator dialogCreator, IUserSettings userSettings)
         : base(view, quantitySelectionPresenter, simulationPersistableUpdater, projectRetriever, dialogCreator, userSettings)
      {
      }

      protected override void RefreshView()
      {
         base.RefreshView();
         int numberOfSelectedMolecules = _quantitySelectionPresenter.NumberOfSelectedQuantities;
         _quantitySelectionPresenter.Info = PKSimConstants.UI.NumberOfGeneratedCurves(numberOfSelectedMolecules * _simulation.NumberOfItems);
      }
   }
}