import numpy as np
import seaborn as sns
import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.neighbors import KNeighborsClassifier
from sklearn.preprocessing import LabelEncoder
from sklearn.metrics import accuracy_score
from sklearn.datasets import load_iris
import joblib

# Load the Iris dataset
iris = load_iris()
data = sns.load_dataset("iris")

# Feature selection
cols_to_drop = ['sepal_width', 'sepal_length' ,'petal_length','petal_width']
data_new = data.drop(cols_to_drop, axis=1)

# Label Encoding for categorical columns
label_encoder = LabelEncoder()
data_new['species'] = label_encoder.fit_transform(data_new['species'])

# Prepare features (X) and target (Y)
X = np.array(data_new.iloc[:, :2])  # Using only two features for simplicity
Y = np.array(data_new.iloc[:, 2])

# Split the data into training and testing sets
x_train, x_test, y_train, y_test = train_test_split(X, Y, train_size=0.8, random_state=3)

# Initialize the KNeighborsClassifier
n_neighbors = 3  # You need to define the number of neighbors
model = KNeighborsClassifier(n_neighbors=n_neighbors)

# Fit the model on the training data
model.fit(x_train, y_train)

# Predict on the test data
y_pred = model.predict(x_test)

# Calculate accuracy
accuracy = accuracy_score(y_test, y_pred)
print(f"Iris Dataset Accuracy: {accuracy}")

# Save the model to a file
joblib.dump(model, "iris_model.pkl")

# Load the model from the file
loaded_model = joblib.load("iris_model.pkl")

# Example prediction
example_prediction = loaded_model.predict([[4.5, 3.0]])
print(f"Example Prediction on Iris Dataset: {example_prediction}")
