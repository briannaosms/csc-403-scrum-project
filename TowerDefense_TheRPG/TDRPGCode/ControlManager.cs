using System.Resources;

namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Used to transfer the form and resource manager from the 
  /// client program to the dll project
  /// </summary>
  public static class ControlManager {
    /// <summary>
    /// Resource manager of the form. Used so we can grab
    /// images
    /// </summary>
    public static ResourceManager ResMan { get; set; }

    /// <summary>
    /// Form object. Used so we can add the controls we
    /// create to the list of controls on the form
    /// </summary>
    public static Form Form { get; set; }
  }
}
