# Unexpected Side Effects with Mutable Variables in F#

This example demonstrates a common issue in F# programming involving mutable variables.  When mutable variables are passed to functions and subsequently modified outside the function, the results within the function can become unpredictable.  This can lead to subtle bugs that are difficult to track down.

The `bug.fs` file contains code exhibiting this problem. The `bugSolution.fs` file demonstrates a solution.